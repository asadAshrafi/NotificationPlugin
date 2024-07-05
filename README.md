Following are the Guidelines to use this plugin.
-To send different types of notifications at a time available in this plugin, wrap one notification type into another and call the outer most notification type's Send method as shown below:

var emailNotification = new EmailNotification("", 503, "", "", "", "");
var smsNotification = new SmsNotification(emailNotification, "123456789");
var slackNotification = new SlackNotification(smsNotification, "slack_webhook_url");
slackNotification.Send("This is a dummy message.");     //outer most notification wrapper

-If you want to send any one of the notification you can do so as well by using another overloaded constructor as shown below:

var slackNotification = new SlackNotification("slack_webhook_url");
slackNotification.Send("This is a dummy message.");

-You can get Notification object by calling following method (returned object contains generated Id as well) :
GetNotificationObject()
