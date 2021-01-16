import { Component, OnInit } from '@angular/core';
import { Product } from '../model/product';
import { NgForm } from '@angular/forms';


@Component({
  selector: 'app-create-product',
  templateUrl: './create-product.component.html',
  styleUrls: ['./create-product.component.css']
})
export class CreateProductComponent implements OnInit {

  public product: Product = new Product('chocolate','candies', 20,10);



  constructor() { }

  ngOnInit(): void {
  
  }


  create_product(productForm: NgForm){
    console.log('creating form',productForm.value)
    if (productForm.valid){
      console.log('creating form', this.product)
    }
    else{
      console.error('product is invalid')
    }
  }



}
