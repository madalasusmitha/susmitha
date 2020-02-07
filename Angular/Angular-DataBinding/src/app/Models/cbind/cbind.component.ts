import { Component, OnInit } from '@angular/core';
import { ViewCustomer } from '../view-customer';

@Component({
  selector: 'app-cbind',
  templateUrl: './cbind.component.html',
  styleUrls: ['./cbind.component.css']
})
export class CbindComponent implements OnInit {
  obj:ViewCustomer

  constructor() { 
    this.obj=new ViewCustomer();
    this.obj.Address='chennai';
    this.obj.City='mgr street';
    this.obj.Contact=9948232069;
    this.obj.Email='madala@sush.com';
    this.obj.Name='susmitha';
  }

  ngOnInit() {
  }

}
