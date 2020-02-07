import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CbindComponent } from './cbind.component';

describe('CbindComponent', () => {
  let component: CbindComponent;
  let fixture: ComponentFixture<CbindComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CbindComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CbindComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
