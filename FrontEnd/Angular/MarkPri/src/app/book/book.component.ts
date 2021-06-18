import { Component, OnInit,Output, EventEmitter } from '@angular/core';
import {Book} from 'src/app/model/book'
import { Product } from '../model/product';


@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {

  public product = new Book("book",'fiction',90,80);

  @Output() private toggleWish: EventEmitter<Book>;

  constructor() { }

  ngOnInit(): void {
    this.toggleWish =  new EventEmitter<Book>();
  }

  toggleWishList(event: any) {
    this.toggleWish.emit(this.product)
  }

  addOrderQuantity(event: any) {
    this.product.order_quantity += 1

  }

  reduceOrderQuantity(event: any) {
    this.product.order_quantity -= 1

  }





}
