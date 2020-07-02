import { Component, OnInit } from '@angular/core';
import { IProducts } from './products';
import { ProductsService } from './products.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  public products: IProducts[];

  constructor(private productsService: ProductsService) { }

  ngOnInit() {
    this.cargarData();
  }

  cargarData() {
    this.productsService.getProducts()
      .subscribe(prod => this.products = prod,
        error => console.error(error));
  }

}
