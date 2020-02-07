import { Component, OnInit } from '@angular/core';
import { View } from '../view';
import { Sign } from '../sign';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  obj:Sign
 constructor() {
   this.obj=new Sign();
  }

  ngOnInit() {
  }
  public Login()
  {
  if(this.obj.username=='admin' && this.obj.password=='abcd')
  {
    console.log("successful")
  }
  else{
    console.log("failed")
  }
    

  }

}
