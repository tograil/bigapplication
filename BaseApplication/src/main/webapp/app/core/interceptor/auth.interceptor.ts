import { Observable } from 'rxjs/Observable';
import { RequestOptionsArgs, Response } from '@angular/http';
import { LocalStorageService, SessionStorageService } from 'ng2-webstorage';
import { JhiHttpInterceptor } from 'ng-jhipster';

export class AuthInterceptor extends JhiHttpInterceptor {

    constructor(
        private localStorage: LocalStorageService,
        private sessionStorage: SessionStorageService
    ) {
        super();
    }

    /*
     * @whatItDoes Adds the authentication token to every http request
     */
    requestIntercept(options?: RequestOptionsArgs): RequestOptionsArgs {
      console.log('intercept');
      // if (!/^api\//.test(options.url)) return options;
        if (!options || !options.url || /^http/.test(options.url)) return options;
        
        const token = this.localStorage.retrieve('authenticationToken') || this.sessionStorage.retrieve('authenticationToken');
        if (!!token) {
            options.headers.append('Authorization', 'Bearer ' + token);
        }
        return options;
    }

    responseIntercept(observable: Observable<Response>): Observable<Response> {
        return observable; // by pass
    }

}
