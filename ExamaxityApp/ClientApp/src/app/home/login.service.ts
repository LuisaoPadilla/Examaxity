import { Injectable, Inject } from '@angular/core';
import { ILogin } from './login';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  cita: ILogin[];
  private apiUrl = "api/Login/";

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }
  
  loginUser(login: ILogin): Observable<ILogin> {
    return this.http.post<ILogin>(this.apiUrl, login);
  }
}
