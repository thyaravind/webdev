import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BookComponent } from './book/book.component';
import { ProductComponent } from './product/product.component';
import { CreateProductComponent } from './create-product/create-product.component';
import { CreateProductFormgroupComponent } from './create-product-formgroup/create-product-formgroup.component';
import { CreateProductReactiveComponent } from './create-product-reactive/create-product-reactive.component';

@NgModule({
  declarations: [
    AppComponent,
    BookComponent,
    ProductComponent,
    CreateProductComponent,
    CreateProductFormgroupComponent,
    CreateProductReactiveComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
