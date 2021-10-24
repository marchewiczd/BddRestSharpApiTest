Feature: GetAllEmployees
    GET requests for employee list

Background: 
    Given I create request to "employees" endpoint
    When I execute "GET" request
    
    
Scenario: Successfully get all employees
    Then returned status code should be "200"
    And returned data should be non empty list of employees