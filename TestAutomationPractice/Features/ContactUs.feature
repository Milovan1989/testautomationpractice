Feature: ContactUs
In order to contact customer service
As a user
I want to be able to use contact us form

@tag1
Scenario: User can contact customer service
	Given user opens contact us page
	When user fill in all required field 'Webmaster' heading and 'QA kurs' message
	And user submits the form
	Then message 'Your message has been successfully sent to our team' is presented to the user
