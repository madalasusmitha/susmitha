import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TwodataComponent } from './twodata.component';

describe('TwodataComponent', () => {
  let component: TwodataComponent;
  let fixture: ComponentFixture<TwodataComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TwodataComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TwodataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
