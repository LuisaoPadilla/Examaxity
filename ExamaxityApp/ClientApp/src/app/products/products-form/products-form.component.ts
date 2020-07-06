import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ProductsService } from '../products.service';
import { IProducts } from '../products';
import { Route } from '@angular/compiler/src/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-products-form',
  templateUrl: './products-form.component.html',
  styleUrls: ['./products-form.component.css']
})
export class ProductsFormComponent implements OnInit {

  constructor(private fb: FormBuilder,
    private service: ProductsService,
    private router: Router) { }

  formGroup: FormGroup;

  ngOnInit() {
    this.formGroup = this.fb.group({
      nombre: '',
      costo: '',
      cantidad: ''
    });
  }

  save()
  {
    let prod: IProducts = Object.assign({}, this.formGroup.value);
    this.service.addProducts(prod)
      .subscribe(resp => this.onSaveSuccess(),
        error => console.error(error));
  }

  onSaveSuccess()
  {
    this.router.navigate(["/products"]);
  }
}
