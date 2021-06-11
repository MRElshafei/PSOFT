"use strict";
var blackPearlHomePort = "@Url.Content("~/tortuga")";




var AymanArray = [
    {
        "category": "Foundation",
        "segments": [{
            "start": 7,
            "duration": 2,
            "color": "#55c4f5",
            "task": "Foundation01"
        }, {
            "duration": 2,
            "color": "#fed230",
            "task": "Foundation02"
        }, {
            "duration": 2,
            "color": "#259e39",
            "task": "Foundation03"
        }]
    }
]






AmCharts.useUTC = true;
var chart = AmCharts.makeChart("chartdiv", {
    "type": "gantt",
    "theme": "light",
    "marginRight": 40,
    "period": "hh",
    "dataDateFormat": "YYYY-MM-DD",
    "balloonDateFormat": "JJ:NN",
    "columnWidth": 0.25,
    "valueAxis": {
        "type": "date",
        "minimum": 7,
        "maximum": 31,
        "fontSize": 10,
        "titleFontSize": 18
    },
    "balloon": {
        "adjustBorderColor": true,
        "borderThickness": 2,
        "shadowAlpha": 0,
        "color": "#353535",
        "cornerRadius": 3,
        "fillColor": "#FFFFFF"
    },
    "categoryAxis": {
        "fontSize": 10,
        "fillColor": "#ededed"
    },
    "brightnessStep": 10,
    "graph": {
        "fillAlphas": 1,
        "balloonText": "<b>[[task]]</b><br/>：[[open]]<br/>：[[value]]"
    },
    "rotate": true,
    "categoryField": "category",
    "segmentsField": "segments",
    "colorField": "color",
    "startDate": "2015-01-01",
    "startField": "start",
    "endField": "end",
    "durationField": "duration",
    "dataProvider": AymanArray,
    "valueScrollbar": {
        "autoGridCount": true
    },
    "chartCursor": {
        "cursorColor": "#55bb76",
        "valueBalloonsEnabled": false,
        "cursorAlpha": 0,
        "valueLineAlpha": 0.5,
        "valueLineBalloonEnabled": true,
        "valueLineEnabled": true,
        "zoomable": false,
        "valueZoomable": true
    },
    "export": {
        "enabled": true
    }
});
