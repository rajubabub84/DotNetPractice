﻿import { Component } from '@angular/core';

@Component({
    selector: 'my-employeelist',
    templateUrl: 'app/employee/employeeList.component.html',
    styleUrls: ['app/employee/employeeList.component.css']
})
export class EmployeeListComponent {
    employees: any[];
    selectedEmployeeCountRadioButton: string = "All";
    constructor() {
        this.employees = [
            { code: 'emp101', name: 'Tom', gender: 'Male', annualSalary: 5500, dateOfBirth: '6/25/1998' },
            { code: 'emp102', name: 'Alex', gender: 'Male', annualSalary: 5700, dateOfBirth: '9/6/1982' },
            { code: 'emp103', name: 'Mike', gender: 'Male', annualSalary: 5900, dateOfBirth: '12/8/1979' },
            { code: 'emp104', name: 'Mary', gender: 'Female', annualSalary: 6500.826, dateOfBirth: '10/14/1980' },
            { code: 'emp105', name: 'Nancy', gender: 'Female', annualSalary: 6700.826, dateOfBirth: '12/15/1982' },
            { code: 'emp106', name: 'Steve', gender: 'Male', annualSalary: 7700.826, dateOfBirth: '10/18/1979' }
        ]
    }  

    onEmployeeCountRadioButtonChange(selectedRadioButtonValue: string): void {
        this.selectedEmployeeCountRadioButton = selectedRadioButtonValue;
    }

    getTotalEmployeesCount(): number {
        return this.employees.length;
    }

    getTotalMaleEmployeesCount(): number {
        return this.employees.filter(e => e.gender === "Male").length;
    }

    getTotalFemaleEmployeesCount(): number {
        return this.employees.filter(e => e.gender === "Female").length;
    }
}