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
        //attach an event to the save button.
        //job 1: find the save button.
        //do this by finding a field on our form, then going out to the enclosing dialog, then finding a button with the word "save" inside.
        //jquery selectors are the best and the worst at the same time!

        //job 2: attach an event to the 'save' button that will redirect to the newly created event
        //note that the JS event fires very quickly, probably a few milliseconds *before* the event has actually finished writing to the database.
        //therefore we set a timeout of one second to allow time for the form to finish saving.
        //this is admittedly janky.  with the infinity SDK, I sometimes think of this line... https://www.youtube.com/watch?v=ou1nGtiu4IE&t=64s
        var eventURLField = $('[id$="NEWEVENTURL_value"]');
        var newEventURL = eventURLField[0].value;
        var buttonsonform = eventURLField.closest('.x-window-bwrap').find('button');
        $(buttonsonform).each(function () {
          if (this.innerHTML === 'Save') {
            $(this).click(function () {
              setTimeout(function () {
                window.location.href = newEventURL;
              }, 1000);
            })
          }
        });
      },
      formupdated: function (args) {
        //Fires when the form is updated on the server, typically triggered by an action or a field's value changing.
        //note that you can also add "normal" javascript event handlers from here.
        //for example, you could attach an "onblur" event to an input box to make the form sing and dance *as* they type.
        //now that you are here, the plumbing is done, and you can do any JS you like.
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