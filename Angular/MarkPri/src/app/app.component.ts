import { Component, ViewEncapsulation, OnInit } from '@angular/core';
import {Product} from 'src/app/model/product';
import {Book} from 'src/app/model/book';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.Emulated,
  interpolation: ['{{','}}']
})
export class AppComponent implements OnInit {
  title = 'eComm';

  public productsObj: Array<Product> = [
    new Product('fiction book','fiction',100,10),
    new Product('biography','non-fiction',10,100),
    new Product('chemistry','non-fiction',500,500)

  ];

  ngOnInit(): void { 

    this.productsObj = [
    new Product('fiction book','fiction',100,10),
    new Product('biography','non-fiction',10,100),
    new Product('chemistry','non-fiction',500,500)

  ]}


  ToggleWishParent(product: Book){
    console.log('toggling the product to wish list',product);
    product.wishlist =! product.wishlist;
  }
 


}
