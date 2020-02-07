import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdsubComponent } from './adsub.component';

describe('AdsubComponent', () => {
  let component: AdsubComponent;
  let fixture: ComponentFixture<AdsubComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdsubComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdsubComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
