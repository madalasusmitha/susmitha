import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-twodata',
  templateUrl: './twodata.component.html',
  styleUrls: ['./twodata.component.css']
})
export class TwodataComponent implements OnInit {
  msg:string="hello";


  constructor() { 
    console.log(this.msg);
  }

  ngOnInit() {
  }

}
