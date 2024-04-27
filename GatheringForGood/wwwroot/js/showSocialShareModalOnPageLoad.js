$(document).ready(function showSocialShareModalOnPageLoad() {

    let showSocialValue = sessionStorage.getItem("showSocial");
    let identifyIconValue = sessionStorage.getItem("identifyIcon");
    let checkBoxStatus = sessionStorage.getItem("checkBoxStatus");
    let page = sessionStorage.getItem("page");

    console.log("showSocialValue: " + showSocialValue);
    console.log("identifyIconValue: " + identifyIconValue);
    console.log("checkBoxStatus: " + checkBoxStatus);
    console.log("page: " + page);

    if (checkBoxStatus == "false" && page == "RGW") {
        let checkbox = document.getElementById('RGWEnableSharingCheckbox');
        checkbox.checked = false;
    } else if (checkBoxStatus == "false" && page == "RDF") {
        let checkbox = document.getElementById('RDFEnableSharingCheckbox');
        checkbox.checked = false;
    } else if (checkBoxStatus == "false" && page == "RAE") {
        let checkbox = document.getElementById('RAEEnableSharingCheckbox');
        checkbox.checked = false;
    }

    if (checkBoxStatus == "true" && showSocialValue == "true")
    {
        switch (page) {
            case "RGW":
                var modal = $('#rgwPageSocialShareModal');
                break;
            case "RDF":
                var modal = $('#rdfPageSocialShareModal');
                break;
            case "RAE":
                var modal = $('#raePageSocialShareModal');
                break;
        }

        switch (identifyIconValue)
        {
            case "ReduceMeat":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }
                var CO2reduction = '2.0075';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I just skipped meat in a meal to help save us from climate change and I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,meat')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "PlantTree":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '21.772';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I just planted a tree to help save us from climate change and it will eliminate an average of ' + CO2reduction + 'Kg CO2e per year! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,trees')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "EatOrganic":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '.140525';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I just used organic ingredients in a meal to help save us from climate change and I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,organic')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "GoVegtarian":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '2.0075';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I just had a vegetarian meal to help save us from climate change and I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,vegetarian')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "GoVegan":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '4.405';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I just had a vegan meal to help save us from climate change and I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,vegan')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "LiveCarFree":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '12.6';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I went car-free today to help save us from climate change and I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,carfree')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "GreenRecovery":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'Im supporting a green recovery from Covid to help save us from climate change! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,greenrecovery')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "MinimisePlastic":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '.0828';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I minimised my plastic usage today to help save us from climate change and I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,plastic')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "BuyLocal":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '.140525';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I just had a meal using only local ingredients to help save us from climate change and I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,buylocal')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "Cycle":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '.178';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I just cycled a local journey to help save us from climate change and I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,cycle')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "DriveElectric":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '3.69863';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I drove electric today to help save us from climate change and I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,electriccars')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "GrowYourOwn":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '.0845041096';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I have been growing my own vegetables to help save us from climate change and today it eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,growyourown')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "RenewableEnergy":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'Today I switched to a renewable energy provider to help save us from climate change! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,renewableenergy')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "PublicTransport":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '12.042';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I used public transport today to help save us from climate change and today I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,publictransport')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "Carpool":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '9.345';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I carpooled today to help save us from climate change and today I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,carpool')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "FlyLess":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I have been making sure that I fly less often to help save us from climate change! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,flyless')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "StandUp":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I have been standing up, contacting politicians and getting involved to help save us from climate change! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,standup')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "RecyclingBin":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '2.484';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I had a full recycling bin today to help save us from climate change and I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,recycling')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "CompostBin":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I have been using a compost bin to help save us from climate change! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,composting')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "HomeInsulation":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '1890';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I completed a home insulation refit today to help save us from climate change and it will eliminate ' + CO2reduction + 'Kg CO2e this year! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,insulation')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "ShorterShowers":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '1.021';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I made sure to take a shorter shower today to help save us from climate change and I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,shortershowers')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "FluorescentBulbs":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '.093';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I installed a flourescent lightbulb today to help save us from climate change and it eliminated ' + CO2reduction + 'Kg CO2e today alone! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,lighting')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "TurnOffLights":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var CO2reduction = '.00775';
                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I have been more careful to switch off lights in empty rooms today to help save us from climate change and I eliminated ' + CO2reduction + 'Kg CO2e! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,switchoff')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "SignPetition":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I signed a petition today to help save us from climate change! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,petition')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "HabitatRestoration":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I took action today to support habitat restoration to help save us from deforestation! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,habitatrestoration')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "ZeroDeforestation":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I helped implement a zero deforestation policy today to help save us from deforestation! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,zerodeforestation')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "Paperless":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I eliminated my use of paper based products today to help save us from deforestation! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,zerodeforestation')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "DonateForestryTrust":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I donated to a forestry trust today to help save us from deforestation! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,zerodeforestation')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "BuyRecycled":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I bought reusable & recycled products today to help save us from deforestation! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,zerodeforestation')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "FollowSocial":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I used social media today to help spread awareness of threats to forests and save us from deforestation! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,zerodeforestation')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "FamilySizes":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'Im supporting reduced family sizes to help reduce animal extinction rates! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,zerodeforestation')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "WildlifeRefuge":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I visited and showed my support for a wildlife refuge today to help reduce animal extinction rates! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,zerodeforestation')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "HerbsAndPests":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I have been making sure not to use herbs and pesticides to help save us from Animal Extinction! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,zerodeforestation')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "SlowDown":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'I made sure to drive a lot slower today to reduce accidents involving animals and help save us from Animal Extinction! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,zerodeforestation')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;

            case "PlantNative":
                modal.find('.modal-title1').text('You Are Making A Difference!')
                modal.find('.modal-body').text('Now Encourage Others To Help Change The World')
                modal.find('.modal-body1').text('Choose Social Channel')
                switch (page) {
                    case "RGW":
                        $('#rgwPageSocialShareModal').modal('show');
                        break;
                    case "RDF":
                        $('#rdfPageSocialShareModal').modal('show');
                        break;
                    case "RAE":
                        $('#raePageSocialShareModal').modal('show');
                        break;
                }

                var tweetBtn = $('<a></a>')
                    .addClass('twitter-share-button')
                    .attr('href', 'http://twitter.com/share')
                    .attr('data-url', 'http://gatheringforgood.com')
                    .attr('data-text', 'Today I planted some native plants to help save us from Animal Extinction! Gather with me for good and help make a difference! 😊')
                    .attr('data-hashtags', 'gatheringforgood,climatechange,makeadifference,zerodeforestation')
                    .attr('data-size', 'large');
                $('#tweetBtn').append(tweetBtn);
                sessionStorage.removeItem("showSocial");
                sessionStorage.removeItem("identifyIcon");
                sessionStorage.removeItem("checkBoxStatus");
                sessionStorage.removeItem("page");
                break;
        }
    }
});