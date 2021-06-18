import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/model/product';
import { NgClass } from '@angular/common';
import { Productv2 } from 'src/app/model/productv2';

@Component({
  selector: 'app-product-item',
  templateUrl: './product-item.component.html',
  styleUrls: ['./product-item.component.css']
})

export class ProductItemComponent implements OnInit {
  public product = new Product("book",'fiction',90,80);

  //public productv2Class = new NgClass;

  //export class productv2Class {}
  

  ngOnInit(): void {
    
  }

  toggleWishList(event: any) {
    console.log('toggling the product to wish list',event);
    this.product.wishlist =! this.product.wishlist;
  }

  addOrderQuantity(event: any) {
    this.product.order_quantity += 1

  }

  reduceOrderQuantity(event: any) {
    this.product.order_quantity -= 1

  }

}
