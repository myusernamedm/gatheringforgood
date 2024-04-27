$('#raePageLearnMoreModal').on('show.bs.modal', function (event) {
    var button = $(event.relatedTarget) // Button that triggered the modal
    var titlerecipient = button.data('title')
    var bodyrecipient = button.data('body')
    var body1recipient = button.data('body1')// Extract info from data-* attributes
    var modal = $(this)
    modal.find('.modal-title').text(titlerecipient)
    modal.find('.modal-body').text(bodyrecipient)
    modal.find('.modal-body1').text(body1recipient)
})