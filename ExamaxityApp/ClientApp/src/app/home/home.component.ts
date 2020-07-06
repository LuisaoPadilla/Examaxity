import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ILogin } from './login';
import { LoginService } from './login.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

  constructor(private fb: FormBuilder,
    private loginService: LoginService,
    private router: Router) { }

  formGroup: FormGroup;

  ngOnInit() {
    this.formGroup = this.fb.group({
      nombre: '',
      password: ''
    });
  }
   
  login() {
    let login: ILogin = Object.assign({}, this.formGroup.value);
    console.table(login);

    this.loginService.loginUser(login)
      .subscribe(login => this.onSaveSuccess(),
        error => this.onSaveError());
  }

  onSaveSuccess() {
    this.router.navigate(["/products"]);
  }

  onSaveError() {
    this.router.navigate(["/"]);
  }
}
