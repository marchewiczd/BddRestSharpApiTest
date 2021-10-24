Feature: GetSingleEmployee
	GET requests for both positive and negative cases for signle employee endpoint
		
Background: 
	Given I create request to "employee/{id}" endpoint
	
Scenario Template: Successfully get single employee
	Given I add parameter "id" of value "<employeeId>"
	When I execute "GET" request
	Then returned status code should be "200"
	And GET response for employee id should be <employeeId>
	And GET response for employee name should be <employeeName>
	And GET response for employee salary should be <employeeSalary>
	And GET response for employee age should be <employeeAge>
	And GET response for profile image should be "<profileImage>"
	
	Examples:
	| employeeId | employeeName | employeeSalary | employeeAge | profileImage |
	| 1          | Tiger Nixon  | 320800         | 61          |              |
	| 5          | Airi Satou   | 162700         | 33          |              |
	| 3          | Ashton Cox   | 86000          | 66          |              |
	| 24         | Doris Wilder | 85600          | 23          |              |
 
Scenario Template: Send GET request to invalid ID
	Given I add parameter "id" of value "<employeeId>"
	When I execute "GET" request
	Then returned status code should be "404"
	
	Examples:
	  | employeeId |
	  | -1         |
	  | 0          |
	  | 154831     |
   
 
Scenario: Send GET request without ID
	Given I add parameter "id" of value ""
	When I execute "GET" request
	Then returned status code should be "404"