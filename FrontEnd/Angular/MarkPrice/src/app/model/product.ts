export class Product {

wishlist: boolean = false;

constructor(public name:string,public type:string, public previousPrice: number, public price: number,public order_quantity = 0){}

priceDropped(): boolean {
return this.price >= this.previousPrice
}

orderQuantityIsZero(): boolean {
    return this.order_quantity == 0
}


}
