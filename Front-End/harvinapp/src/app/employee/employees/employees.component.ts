import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/core/data.service';
import { Employee } from 'src/app/employee';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatTableDataSource } from '@angular/material/table';

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

  constructor(private dataService: DataService, private fb: FormBuilder) {

    this.form = this.fb.group({
      search: ['', null]
    });

  }

  ngOnInit() {

  }

  loadAllEmployees() {
    this.dataService
      .getAll()
      .subscribe((data: Employee[]) => {
        this.employeeTable = data;
        this.empleoyeeTableDataSource.data = this.employeeTable;
      });

  }
  loadEmployee(id: number) {
    this.dataService
      .getById(id)
      .subscribe((data: Employee) => {
        this.employeeTable.push(data);
        this.empleoyeeTableDataSource.data = this.employeeTable;
      });
  }

  onSearchEmployee() {
    let searchValue: string = this.form.get('search').value;
    this.empleoyeeTableDataSource.data.splice(0, this.empleoyeeTableDataSource.data.length);

    if (searchValue.length === 0)
      this.loadAllEmployees();
    else
      this.loadEmployee(parseInt(searchValue));

    this.empleoyeeTableDataSource._updateChangeSubscription();

  }


}
