import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class AccountService  {
    constructor(private http: HttpClient) { }

    get(): Observable<any> {
        return this.http.get('api/account').map((res: HttpResponse<any>) => res);
    }

    save(account: any): Observable<any> {
        return this.http.post('api/account', account);
    }
}
