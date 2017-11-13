import { Injectable } from '@angular/core';
import { Http, Response, Headers, URLSearchParams, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { LocalStorageService, SessionStorageService } from 'ng2-webstorage';

@Injectable()
export class AuthServerProvider {
    constructor(
        private http: Http,
        private $localStorage: LocalStorageService,
        private $sessionStorage: SessionStorageService
  ) { }
    


    isAutenticated() {

    }

    getToken() {
        return this.$localStorage.retrieve('authenticationToken') || this.$sessionStorage.retrieve('authenticationToken');
    }

    toRaw(data): string {
      return 'grant_type=' + data.grant_type
        + '&scope=' + data.scope
        + '&client_id=' + data.client_id
        + '&client_secret=' + data.client_secret
        + '&username=' + data.username
        + '&password=' + data.password;
    }


    login(credentials): Observable<any> {

        const data = {
            username: credentials.username,
            password: credentials.password,
            grant_type: 'password',
            scope: 'api',
            client_id: 'client',
            client_secret: 'secret',


      };
        let options = new RequestOptions();
        options.headers = new Headers();
        options.headers.append('Content-Type', 'application/x-www-form-urlencoded');


        return this.http.post('connect/token', this.toRaw(data), options).map(authenticateSuccess.bind(this));

        function authenticateSuccess(resp) {

          const bearerToken = `Bearer ${resp._body.access_token}`;
          const jwt = resp._body.access_token;
          this.storeAuthenticationToken(jwt, credentials.rememberMe);
          return jwt;
            /*if (bearerToken && bearerToken.slice(0, 7) === 'Bearer ') {
                const jwt = bearerToken.slice(7, bearerToken.length);
                this.storeAuthenticationToken(jwt, credentials.rememberMe);
                return jwt;
            }*/
        }
    }

    loginWithToken(jwt, rememberMe) {
        if (jwt) {
            this.storeAuthenticationToken(jwt, rememberMe);
            return Promise.resolve(jwt);
        } else {
            return Promise.reject('auth-jwt-service Promise reject'); // Put appropriate error message here
        }
    }

    storeAuthenticationToken(jwt, rememberMe) {
        if (rememberMe) {
            this.$localStorage.store('authenticationToken', jwt);
        } else {
            this.$sessionStorage.store('authenticationToken', jwt);
        }
    }

    logout(): Observable<any> {
        return new Observable((observer) => {
            this.$localStorage.clear('authenticationToken');
            this.$sessionStorage.clear('authenticationToken');
            observer.complete();
        });
    }
}
