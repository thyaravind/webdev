import { NgClass } from '@angular/common';
import { NgForm } from '@angular/forms';


export class Product {


    public saleCSS:any;
    wishlist: boolean = false;
    public buyOptions: Array<string> = ['COD','Delivery']
    public buyOption: string;
    
    constructor(public name:string,public type:string, public previousPrice: number, public price: number,public sku: string = 'sku',public seller: string = '',public order_quantity = 0){

        this.saleCSS = {
            'sale': this.priceDropped(),
            'not-sale': !this.priceDropped()
          }
        this.buyOption = 'COD';
    }
    
    priceDropped(): boolean {
    return this.price <= this.previousPrice
    }
    
    orderQuantityIsZero(): boolean {
        return this.order_quantity > 0
    }
    
    create(productForm: NgForm) {
        
        console.log('creating the product',productForm,this.name, this.sku, this.seller)
    }
    
    }