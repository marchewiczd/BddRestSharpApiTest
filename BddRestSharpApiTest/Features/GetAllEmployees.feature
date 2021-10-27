Feature: GetAllEmployees
    As an administrator I want to be able to request all employees list


Background:
    Given I create request to "employees" endpoint
    When I execute "GET" request


Scenario: Successfully get all employees
    Then returned status code should be "200"
    And returned data should be non empty list of employees