Feature: DeleteEmployee
	As an administrator I want to be able to delete exisiting employees


Background:
	Given I create request to "delete/{id}" endpoint


Scenario Template: Successfully delete existing employee
	Given I add parameter "id" of value "<employeeId>"
    When I execute "DELETE" request
    Then returned status code should be "200"

    Examples:
    | employeeId |
    | 15         |


Scenario: Send delete request without specifying ID
	Given I add parameter "id" of value ""
	When I execute "DELETE" request
	Then returned status code should be "405"