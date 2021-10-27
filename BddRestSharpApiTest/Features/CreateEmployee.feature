Feature: CreateEmployee
    As an administrator I want to be able to create employee record

Background:
    Given I create request to "create" endpoint


Scenario Template: Successfully create new employee by sending full JSON body
    Given I have given data in JSON body:
      | Name           | Salary           | Age           |
      | <employeeName> | <employeeSalary> | <employeeAge> |
    When I execute "POST" request

    # status code should be 201
    Then returned status code should be "200"
    And response for employee name should be "<employeeName>"
    And response for employee salary should be <employeeSalary>
    And response for employee age should be <employeeAge>

    Examples:
    | employeeName | employeeSalary | employeeAge |
    | Foo          | 123321         | 34          |



Scenario: Successfully create new employee by sending empty JSON body
    Given I have empty JSON body
    When I execute "POST" request
    # status code should be 201
    Then returned status code should be "200"