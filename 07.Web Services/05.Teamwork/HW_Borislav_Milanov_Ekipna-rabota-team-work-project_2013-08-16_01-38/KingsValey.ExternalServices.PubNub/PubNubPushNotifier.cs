namespace KingsValey.ExternalServices.PubNub
{
    public static class PubNubPushNotifier
    {
        public static PubnubAPI pubnub = new PubnubAPI(
            "pub-c-d65d8479-2b15-4bae-9823-73c9bb019902",               // PUBLISH_KEY
            "sub-c-bd355e94-04bd-11e3-991c-02ee2ddab7fe",               // SUBSCRIBE_KEY
            "sec-c-Mjk5YTQ1ODgtNWM4OC00MTVmLWE5NjUtZmZiZTAwYjUwZTQx",   // SECRET_KEY
            true                                                        // SSL_ON?
        );

        public static void PushData(string channel, object data)
        {
            pubnub.Publish(channel, data);
        }
    }
}