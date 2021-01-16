import { Component, OnInit,Input} from '@angular/core';
import {Product} from 'src/app/model/product'
import { NgClass } from '@angular/common';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent{


  @Input() public products: Array<Product>;


  constructor() { 
  }

  toggleWishList(event: any,i: any) {
    console.log('toggling the product to wish list',event);
    this.products[i].wishlist =! this.products[i].wishlist;
  }

  addOrderQuantity(event: any,i: any) {
    this.products[i].order_quantity += 1

  }

  reduceOrderQuantity(event: any,i: any) {
    this.products[i].order_quantity -= 1

  }

}
