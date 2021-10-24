Feature: UpdateEmployee
	PUT requests for updating employee data
		
Background: 
	Given I create request to "update/{id}" endpoint
	
Scenario Template: Successfully create new employee by sending full JSON body
	Given I add parameter "id" of value "<employeeId>"
    And I have given data in JSON body:
      | Name           | Salary           | Age           |
      | <employeeName> | <employeeSalary> | <employeeAge> | 
    When I execute "PUT" request
    Then returned status code should be "200"
    And response for employee name should be "<employeeName>"
    And response for employee salary should be <employeeSalary>
    And response for employee age should be <employeeAge>
    
    Examples: 
    | id | employeeName | employeeSalary | employeeAge |
    | 15 | Foo          | 123321         | 34          |
    | 1  | Bar          | 884291         | 55          |
    
Scenario: Send update request without specifying ID
	Given I add parameter "id" of value ""
	When I execute "PUT" request
	Then returned status code should be "405"