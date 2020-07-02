import { Injectable, Inject } from '@angular/core';
import { IProducts } from './products';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  prod: IProducts[];
  private apiUrl = "api/Products/";

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }


  getProducts(): Observable<IProducts[]> {
    return this.http.get<IProducts[]>(this.apiUrl);
  }
}
