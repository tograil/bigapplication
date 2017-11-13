import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class Register {

    constructor(private http: Http) {}

    save(account: any): Observable<any> {
      console.log('registering');
        return this.http.post('/api/account/register', account);
    }
}
