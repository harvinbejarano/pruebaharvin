import { CoreModule } from './../core/core.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeesComponent } from './employees/employees.component';
import { MaterialModule } from '../material/material.module';

@NgModule({
  declarations: [EmployeesComponent],
  imports: [
    CommonModule,
    MaterialModule,
  ],
  exports:[EmployeesComponent]
})
export class EmployeeModule { }
