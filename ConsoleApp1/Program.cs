using NotificationPlugin;

//var emailNotification = new EmailNotification("", 503, "", "", "", "");
//var smsNotification = new SmsNotification(emailNotification, "123456789");
//var slackNotification = new SlackNotification(smsNotification, "slack_webhook_url");
//slackNotification.Send("This is a dummy message.");

var slackNotification = new SlackNotification("slack_webhook_url");
slackNotification.Send("This is a dummy message.");