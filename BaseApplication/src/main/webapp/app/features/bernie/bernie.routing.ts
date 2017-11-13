import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Store } from '@ngrx/store';

import { BerniePage } from './bernie.page';
import { UserRouteAccessService } from '../../shared';
import { ClaimsResolver } from './claims.resolver';

const routes: Routes = [
    {
        path: '', component: BerniePage,
        data: {
            //authorities: ['ROLE_USER'],
            pageTitle: 'greatBigExampleApplicationApp.bernie.home.title'
        },
        canActivate: [UserRouteAccessService]
    },
    {
        path: ':claimId', component: BerniePage,
        data: {
            //authorities: ['ROLE_USER'],
            pageTitle: 'greatBigExampleApplicationApp.bernie.home.title'
        },
        resolve: {
            deepClaims: ClaimsResolver
        },
        canActivate: [UserRouteAccessService]
    }
];

export const routedComponents = [BerniePage];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    exports: [
        RouterModule
    ],
    providers: [
        ClaimsResolver
    ]
})
export class BernieRouting { }
