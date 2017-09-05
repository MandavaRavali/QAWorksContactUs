Feature: Conatct Us Page
	As an end user
	I want contact us page
	So that I can find out more about QAWORKS


	Scenario: Valid Submission
	Given I am on the Qaworks site
	When I navigate to Contact page
	Then I should be able to contact qaworks with the following info
	|name     |email                |message                                   |
	|j.Bloggs |j.Bloggs@qaworks.com |please contact me I want to find out more |

