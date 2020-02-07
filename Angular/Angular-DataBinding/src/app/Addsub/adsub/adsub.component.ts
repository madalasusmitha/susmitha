import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-adsub',
  templateUrl: './adsub.component.html',
  styleUrls: ['./adsub.component.css']
})
export class AdsubComponent implements OnInit {
  
  num1:number
  num2:number

  constructor() { }

  ngOnInit() {
  }
  public Addition(n1:number,n2:number)
  {
    
   this.num1=Number(n1)+Number(n2);
  
  }
  public sub(n3:number,n4:number)
  {
    this.num2=Number(n3)-Number(n4);

    
  }

}
