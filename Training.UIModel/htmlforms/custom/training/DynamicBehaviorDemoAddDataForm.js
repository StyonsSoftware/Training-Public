/*
Blackbaud provides a framework for JavaScript development, which they call "BBUI".

You can read all about it in these two locations:
  https://webfiles.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/webshell-javascript/Content/WebShell/coWebshellWritingJSforUIModelDataForm2.htm%3FTocPath%3DJavaScript%7CWrite%2520JavaScript%2520for%2520the%2520Infinity%2520Platform%7C_____3

  https://webfiles.blackbaud.com/files/support/guides/infinitytechref/Content/apidocs-BB_4-0/index.html

In this example JS file, I have put in a handler for every public event.
The only event handler that actually *does* anything is "formupdated".
The others are there just for your reference, so you can get an idea of what is possible.
If you really wanted to, you could get rid of these comments and the other handlers and reduce
this file down to about 5 lines of code.

BBCRM is very aggressive about caching JS files.
If you change your file, deploy it, and do *not* see it take effect, then you may need
to manually clear your browser's cache.  I have found this Firefox extension to be very helpful:
https://addons.mozilla.org/en-US/firefox/addon/empty-cache-button/

I am sure there are many equivalents for other, lesser browsers :)
*/
(function (container, modelInstanceId) {
  var util = BBUI.forms.Utility;
  container.on(
    {
      render: function (args) {
        /*
        Fires when the form has been rendered and is visible to the user.
        Listeners will be called with the following arguments:
        
            args : Object
            An object with the following properties:
                bounds : The initial bounds of the form container element.
                sizable : A Boolean value indicating whether the form is resizable.
         */

        //food for thought:
        //here is a snippet that rearranges the fields from an extension
        //form to be "inline" with the OOB form, for a more seamless look
        //var aboveRow = $("tr[id*='EXTENSIONFIELD_container'");
        //var belowRow = $("tr[id*='OOBFIELD_container'");
        //belowRow.insertAfter(aboveRow);
      },
      formupdated: function (args) {
        //Fires when the form is updated on the server, typically triggered by an action or a field's value changing.
        var needMoreRoom = container.getFieldByName("MAKENOTEBIGGER", modelInstanceId).value;
        var noteField = $("[id$=NOTE_value]")[0];
        noteField.rows = (needMoreRoom ? 7 : 3);
      },
      parentresize: function (args) {
        //Fires when the form is updated on the server, typically triggered by an action or a field's value changing.
      },
      beforedestroy: function (args) {
        //Fired before the form container is destroyed. This event should be handled to clean up any DOM events,
        //objects or event handlers used in a UI model custom JavaScript implementation. Neglecting to clean up these
        //resources can result in memory leaks in some browsers.
      },
      asyncerror: function (args) {
        /*
        Fires when an error occurs during an asynchronous operation, such as an asynchronous web request.
        Listeners will be called with the following arguments:
        
            args : Object
            An object with the following properties:
                error : An object whose message property contains the error message.
                sessionExpired : A Boolean value indicating whether the user's form session has expired.
            isFatal : Boolean
            Indicates whether the error is fatal or whether the user can continue interacting with the form.
         */
      }
    })
})();