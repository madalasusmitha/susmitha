import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DemoComponent } from './Interploation/demo/demo.component';
//import { ViewComponent } from './UI/view/view.component';
import { CustomerComponent } from './Models/customer/customer.component';
import { ViewComponent } from './Property-Binding/view/view.component';
import { CbindComponent } from './Models/cbind/cbind.component';
import { EventdemoComponent } from './eventbinding/eventdemo/eventdemo.component';
import { AdsubComponent } from './Addsub/adsub/adsub.component';
import { TwodataComponent } from './Models/twodata/twodata.component';
import { DemocComponent } from './TwoWaybinding/democ/democ.component';


@NgModule({
  declarations: [
    AppComponent,
    DemoComponent,
    ViewComponent,
    CustomerComponent,
    CbindComponent,
    EventdemoComponent,
    AdsubComponent,
    TwodataComponent,
    DemocComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [DemocComponent]
})
export class AppModule { }
