'use strict';

(function () {

    let locations = [
        {
            'code': 'l01',
            'title': 'سالن اصلی',
            'seats': [5, 18, 18, 18, 24, 24, 24, 20, 18, 16, 14, 14, 14]
        },
        {
            'code': 'l02',
            'title': 'سالن خلیج فارس',
            'seats': [26, 18, 20, 20, 24, 24, 10, 18, 16, 10, 10, 10]
        },
        {
            'code': 'l03',
            'title': 'سالن رودکی',
            'seats': [16, 16, 16, 16, 16, 14, 14, 14, 20, 20, 20, 10, 12, 12, 12, 12]
        }
    ];

    function fillLocationsDropDown() {
        for (let location of locations) {
            $('<option>')
                //.attr('value', location.code)
                .val(location.code)
                .html(location.title)
                .appendTo('#locations');
        }
    }
    $(function () {
        fillLocationsDropDown();
        $('#seat-map').css('text-align', 'center');
        $('#locations').on('change', function () {
            //debugger;
            let $locations = $(this);
            
            if ($locations.val() != -1) {
                //یک سالن انتحاب شده است
                let selectedLocation = {};
                for (let location of locations) {
                    if (location.code == $locations.val()) {
                        selectedLocation = location;
                    }
                }

                $('#seat-map').html('');
                for (var i = 0; i < selectedLocation.seats.length; i++) {
                    $('<div>').addClass('col-sm-1').html(i + 1).appendTo('#seat-map');
                    let rowSeatCount = selectedLocation.seats[i];
                    let $seatsRowDiv = $('<div>').addClass('col-sm-11 seat-row');
                    for (var j = 1; j <= rowSeatCount; j++) {
                        $('<button>').addClass('btn btn-success btn-xs seat-btn')
                            .on('click', function () {
                                $('#submit-btn').removeClass('hidden');
                                let $clickedButton = $(this);
                                $clickedButton
                                    .toggleClass('btn-success')
                                    .toggleClass('btn-primary selected-seat');
                            })
                            .attr('data-row', (i + 1).toString())
                            .html(j)
                            .appendTo($seatsRowDiv);
                    }
                    $('#seat-map').append($seatsRowDiv);
                }
            }
            else {

            }
        });


        $('#submit-btn').on('click', function () {
            let selectedSeats = [];
            $('.selected-seat').each(function (ix) {
                debugger;
                let $element = $(this);
                let seat = { 'seat': $element.html(), 'row': $element.attr('data-row') };
                selectedSeats.push(seat);
            });

            $('#confirm-table tbody').html('');
            for (let seat of selectedSeats) {
                $('<tr>')
                    .append($('<td>').html(seat.row))
                    .append($('<td>').html(seat.seat))
                    .appendTo($('#confirm-table tbody'));
            }

            $('#reservation-modal').modal();
        });
    });

})();