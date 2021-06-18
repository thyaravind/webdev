import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class AuthService {

  constructor(private http:HttpClient){}


  Register(credentials){
    this.http.post<any>(`https://localhost:5001/api/account/register`,credentials).subscribe(res => {
      this.authenticate(res)
    });
  }



  Login(credentials){
    this.http.post<any>(`https://localhost:5001/api/account/login`,credentials).subscribe(res => {
      this.authenticate(res)
    });
  }

  authenticate(res){
    localStorage.setItem('token',res)
    this.router.navigate(['/'])

  }

}
