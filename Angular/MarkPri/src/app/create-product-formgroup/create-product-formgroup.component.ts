import { Component, OnInit } from '@angular/core';
import { Product } from '../model/product';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-create-product-formgroup',
  templateUrl: './create-product-formgroup.component.html',
  styleUrls: ['./create-product-formgroup.component.css']
})
export class CreateProductFormgroupComponent implements OnInit {

  public product: Product = new Product('chocolate','candies', 20,10);


  constructor() { }

  ngOnInit(): void {
  }

  create_product(productForm: NgForm){
    console.log('creating form',productForm.value)
    if (productForm.valid){
      this.product = productForm.value.productFormGroup
      console.log('creating form', this.product)
    }
    else{
      console.error('product is invalid')
    }
  }



}
