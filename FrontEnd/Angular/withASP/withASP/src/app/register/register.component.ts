import { Component, OnInit } from '@angular/core';
import {FormBuilder, Validators} from'@angular/forms';
import { AuthService } from '../auth.service';

@Component({
  selector: 'register',
  templateUrl: './register.component.html',
})
export class RegisterComponent {

  form
  constructor(public auth: AuthService,private fb: FormBuilder) {
    this.form = fb.group({
      email: ["",Validators.email],
      username: ["",Validators.required],
      password: ["",Validators.required]
    })
  }



}
