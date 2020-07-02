import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ILogin } from './login';
import { LoginService } from './login.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  constructor(private fb: FormBuilder,
    private citasService: LoginService,
    private router: Router,
    private activatedRoute: ActivatedRoute) { }

  public modoEdicion: boolean = false;
  formGroup: FormGroup;
  public citaId: number;

  ngOnInit() {
    this.formGroup = this.fb.group({
      nombre: '',
      password: ''
    });
  }
   
  login() {
    let login: ILogin = Object.assign({}, this.formGroup.value);
    console.table(login);

    this.citasService.loginUser(login)
      .subscribe(persona => this.onSaveSuccess(),
        error => console.error(error));
  }

  onSaveSuccess() {
    this.router.navigate(["/products"]);
  }
}
