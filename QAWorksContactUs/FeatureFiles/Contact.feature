Feature: Conatct Us Page
	As an end user
	I want contact us page
	So that I can find out more about QAWORKS

	@ContactUsPage
	Scenario: Valid Submission
	Given I am on the Qaworks site
	When I navigate to Contact page
	Then I should be able to contact qaworks with the following info
	|name     |email                |message                                     |
	|j.Bloggs |j.Bloggs@qaworks.com |please contact me I want to find out more   |

	@EmailUsPage
	Scenario: Drop Email
	Given I am on the Qaworks site
	When I navigate to Contact page
	Then Click on Drop Email to navigate to Email page
	
		
	@CareersPage
	Scenario: Carrer opputunities
	Given I am on the Qaworks site
	When I navigate to Contact page
	And  navigate to Careers page
	Then I should be able to get the list of the jobs

	
	
