import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { ProductListingComponent } from './product-listing/product-listing.component';
import { ProductPageComponent } from './product-listing/product-page/product-page.component';
import { RouterModule, Routes } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './header/header.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { SignupPageComponent } from './signup-page/signup-page.component';
import { ApiService } from './services/api.service';
import { AuthService } from './services/auth.service';

const routes: Routes = [
  { path: 'register', component: SignupPageComponent },
  { path: 'login', component: LoginPageComponent },
  { path: ':id', component: ProductPageComponent },
  { path: '', component: ProductListingComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    ProductListingComponent,
    ProductPageComponent,
    HeaderComponent,
    LoginPageComponent,
    SignupPageComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    BrowserAnimationsModule,
  ],
  exports: [RouterModule],
  providers: [ApiService, AuthService],
  bootstrap: [AppComponent],
})
export class AppModule {}
