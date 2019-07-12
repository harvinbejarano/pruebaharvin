import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/employee';
import { MatTableDataSource } from '@angular/material/table';
import { FormGroup, FormBuilder } from '@angular/forms';
import { DataService } from 'src/app/core/data.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.scss']
})
export class EmployeesComponent implements OnInit {

  employeeTable: Employee[] = [];
	empleoyeeTableDataSource = new MatTableDataSource(
		this.employeeTable,
	);
	displayedColumns: string[] = [
		'id',
		'name',
		'contractTypeName',
		'roleName',
		'hourlySalary',
		'monthlySalary',
		'annualSalary',
	];
	form: FormGroup;

  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.loadAllEmployees();
  }

  loadAllEmployees() {
    this.dataService
      .getAll()
      .subscribe((data: Employee[]) => {
          this.employeeTable = data;
          this.empleoyeeTableDataSource.data = this.employeeTable;
       });
  }

  onSearchEmployee() {
    
  }


}
