import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { GreatBigExampleApplicationSharedModule } from '../shared/shared.module';

import {
    JhiMainComponent,
    NavbarComponent,
    FooterComponent,
    ProfileService,
    PageRibbonComponent,
    ActiveMenuDirective,
    ErrorComponent,
    MealsLayoutComponent,
    StandardLayoutComponent,
    StatusBarComponent,
    StatusBarAwareDirective
} from './';
import { MealsModule } from '../features/meals/meals.module';

export const components = [
    JhiMainComponent,
    NavbarComponent,
    FooterComponent,
    PageRibbonComponent,
    ActiveMenuDirective,
    ErrorComponent,
    MealsLayoutComponent,
    StandardLayoutComponent,
    StatusBarComponent,
    StatusBarAwareDirective
];

@NgModule({
    imports: [
        GreatBigExampleApplicationSharedModule,
        BrowserModule,
        RouterModule,
        MealsModule
    ],
    declarations: [
        ...components
    ],
    providers: [
    ],
    exports: [
        ...components
    ]
})

export class LayoutsModule { }
