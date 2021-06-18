import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateProductFormgroupComponent } from './create-product-formgroup.component';

describe('CreateProductFormgroupComponent', () => {
  let component: CreateProductFormgroupComponent;
  let fixture: ComponentFixture<CreateProductFormgroupComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateProductFormgroupComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateProductFormgroupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
