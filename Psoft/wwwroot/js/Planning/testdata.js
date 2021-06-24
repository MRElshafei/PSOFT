//document.getElementById("ProjectStartDate").defaultValue = "2020-01-01";

//document.getElementById("ProjectEndDate").value

function CalculateDays(start, duration, percent) {
    //console.log(`Calculate Days`);
    //console.log(`Start is ${start}`);
    //console.log(`End is ${duration}`);
    //console.log(`Percent is ${percent}`);
    var startday = Math.abs(parseInt(start.substring(0, 2)));
    //console.log(`StartDay IN CalcDays = ${startday}`);
    var startmonth = parseInt(start.substring(3, 5));
    /*console.log(`StartMonth IN CalcDays = ${startmonth}`)*/;



    var numberOfMonthes = Math.floor(duration / 30);
    //console.log(`numberOfMonthesaaaaaaaaaa = ${numberOfMonthes}`);
    var numberOfDays = Math.floor(((duration / 30) - Math.floor(duration / 30)) * 30);
    //console.log(`numberOfDaysaaaaaaaaaaaaa = ${numberOfDays}`);


    var endtday = startday + numberOfDays;
    //console.log(`EndDay IN CalcDays = ${endtday}`);
    var endtmonth = startmonth + numberOfMonthes;
    //console.log(`EndMonth IN CalcDays = ${endtmonth}`);

    var NoOfDays = ((endtmonth - startmonth) * 30) + (endtday - startday);
    //console.log(`Number Of Days IN CalcDays = ${NoOfDays}`);

    var FinalNumberOfDays = Math.floor(NoOfDays * (percent / 100));
    //console.log(`Total Final Number IN CalcDays = ${FinalNumberOfDays}`);

    return FinalNumberOfDays;
}

function CalculateStartDate(Percen, taskId, DependentTaskId) {
    //console.log(`Start Date`);
    console.log(`TaskId = ${taskId}`);
    var S;
    if (taskId > 10 && taskId < 99) {

        //var x = parseInt(taskId.substring(0, 1));
        //var y = parseInt(taskId.substring(2, 3));
        //var taskPercent = Percen[x + y + 1];
        var PreviousPercentage = 0;
        if (taskId == 11) {
            PreviousPercentage = 0;
        } else if (taskId == 12) {
            PreviousPercentage = Percen01[1];
        } else {
            PreviousPercentage = Percen01[1] + Percen02[1];
        }
        for (var i = 0; i < PhaseOne.length; i++) {
            if (DependentTaskId == PhaseOne[i].id) {
                PrevExcutionDays = CalculateDays(PhaseOne[i].start_date, PhaseOne[i].duration, PreviousPercentage);
                console.log(`PrevExcutionDays = ${PrevExcutionDays}`);
                //var numberOfMonthes = Math.ceil(PrevExcutionDays / 30);
                //var numberOfDays = Math.round(PrevExcutionDays % 30);

                var numberOfMonthes = Math.floor(PrevExcutionDays / 30);
                //console.log(`numberOfMonthesaaaaaaaaaa = ${numberOfMonthes}`);
                var numberOfDays = Math.floor(((PrevExcutionDays / 30) - Math.floor(PrevExcutionDays / 30)) * 30);
                //console.log(`numberOfDaysaaaaaaaaaaaaa = ${numberOfDays}`);

                var startday = Math.abs(parseInt(PhaseOne[i].start_date.substring(0, 2)));
                var startmonth = parseInt(PhaseOne[i].start_date.substring(3, 5));


                var d = (numberOfDays + startday);
                var m = (numberOfMonthes + startmonth);
                if (d > 30) {
                    d = d - 30;
                    m++;
                    //S = `2020-${m}-${d}`;
                    S = `${d}-${m}-2020`;
                } else {
                    S = `${d}-${m}-2020`;
                }


            }
        }

    } else {
        var x = (Math.floor(taskId / 100))-1;
        //console.log(`x = ${x}`);
        var y = (Math.floor((taskId-100)/10))-1;
        //console.log(`y = ${y}`);
        var z = (taskId - (((x+1)*100)+((y+1)*10)))-1;
        //console.log(`z = ${z}`);
        var taskPercent = Percen[x + y + z + 2];
        var PreviousPercentage = 0;
        if (y == 0) {
            for (var i = z + 1; i > 1; i--) {
                PreviousPercentage = PreviousPercentage + Percen01[i];
                //console.log(`Percen[i] = ${Percen[i]}`)
                //console.log(`i = ${i}`)
            }
        } else if (y == 1) {
            for (var i = z + 1; i > 1; i--) {
                PreviousPercentage = PreviousPercentage + Percen02[i];
                //console.log(`Percen[i] = ${Percen[i]}`)
                //console.log(`i = ${i}`)
            }
        } else {
            for (var i = z + 1; i > 1; i--) {
                PreviousPercentage = PreviousPercentage + Percen03[i];
                //console.log(`Percen[i] = ${Percen[i]}`)
                //console.log(`i = ${i}`)
            }
        }

        //console.log(`PreviousPercentage = ${PreviousPercentage}`);
        for (var i = 0; i < PhaseTwo.length; i++) {
            if (DependentTaskId == PhaseTwo[i].id) {
                //console.log(`Dependant Task Name = ${PhaseTwo[i].name}`)
                PrevExcutionDays = CalculateDays(PhaseTwo[i].start_date, PhaseTwo[i].duration, PreviousPercentage);
                //console.log(`PrevExcutionDays = ${PrevExcutionDays}`);

                //var numberOfMonthes = Math.floor(PrevExcutionDays / 30);
                ////console.log(`numberOfMonthes = ${numberOfMonthes}`);
                //var numberOfDays = Math.round(PrevExcutionDays % 30);
                ////console.log(`numberOfDays = ${numberOfDays}`);

                var numberOfMonthes = Math.floor(PrevExcutionDays / 30);
                console.log(`numberOfMonthesaaaaaaaaaa = ${numberOfMonthes}`);
                var numberOfDays = Math.floor(((PrevExcutionDays / 30) - Math.floor(PrevExcutionDays / 30)) * 30);
                console.log(`numberOfDaysaaaaaaaaaaaaa = ${numberOfDays}`);

                var startday = Math.abs(parseInt(PhaseTwo[i].start_date.substring(0, 2)));
                //console.log(`startday = ${startday}`);
                var startmonth = parseInt(PhaseTwo[i].start_date.substring(3, 5));
                //console.log(`startmonth = ${startmonth}`);

                var d = (numberOfDays + startday);
                //console.log(`Day Number is = ${d}`);
                var m = (numberOfMonthes + startmonth);
                //console.log(`Month Number is = ${m}`);

                if (d > 30) {
                    d = d - 30;
                    m++;
                    S = `${d}-${m}-2020`;
                } else {
                    S = `${d}-${m}-2020`;
                }

                S = `${d}-${m}-2020`;
            }
        }
    }

    return S;
}

function CalculateEndDate(Percen, taskId, DependentTaskId, percentage) {
    console.log(`End Date`);
    console.log(`Task Id Is ${taskId}`);
    console.log(`Percentage Is ${percentage}`);
    var E;

    var startDateOfTheTask = CalculateStartDate(Percen, taskId, DependentTaskId);

    if (taskId.length == 3) {
        for (var i = 0; i < PhaseOne.length; i++) {
            if (DependentTaskId == PhaseOne[i].id) {
                var PrevExcutionDays = CalculateDays(PhaseOne[i].start, PhaseOne[i].end, percentage);
                console.log(`PrevExcutionDays = ${PrevExcutionDays}`);

                var numberOfMonthes = Math.floor(PrevExcutionDays / 30);
                console.log(`numberOfMonthesaaaaaaaaaa = ${numberOfMonthes}`);
                var numberOfDays = Math.floor(((PrevExcutionDays / 30) - Math.floor(PrevExcutionDays / 30)) * 30);
                console.log(`numberOfDaysaaaaaaaaaaaaa = ${numberOfDays}`);

                //var numberOfMonthes = Math.round(PrevExcutionDays / 30);
                ////console.log(`numberOfMonthes = ${numberOfMonthes}`);
                //var numberOfDays = Math.round(PrevExcutionDays % 30);
                ////console.log(`numberOfDays = ${numberOfDays}`);

                var startday = Math.abs(parseInt(startDateOfTheTask.substring(0, 2)));
                console.log(`startday = ${startday}`);
                var startmonth = parseInt(startDateOfTheTask.substring(3, 5));
                console.log(`startmonth = ${startmonth}`);

                var d = (numberOfDays + startday);
                var m = (numberOfMonthes + startmonth);
                if (d > 30) {
                    d = d - 30;
                    m++;
                    E = `${d}-${m}-2020`;

                } else {
                    E = `${d}-${m}-2020`;
                }
            }
        }
    }
    else {
        for (var i = 0; i < PhaseTwo.length; i++) {
            if (DependentTaskId == PhaseTwo[i].id) {
                console.log(`pahseTwo.id = ${PhaseTwo[i].id}`)
                var PrevExcutionDays = CalculateDays(PhaseTwo[i].start, PhaseTwo[i].end, percentage);
                console.log(`PrevExcutionDays = ${PrevExcutionDays}`);

                var numberOfMonthes = Math.floor(PrevExcutionDays / 30);
                console.log(`numberOfMonthesaaaaaaaaaa = ${numberOfMonthes}`);
                var numberOfDays = Math.floor(((PrevExcutionDays / 30) - Math.floor(PrevExcutionDays / 30)) * 30);
                console.log(`numberOfDaysaaaaaaaaaaaaa = ${numberOfDays}`);

                var startday = Math.abs(parseInt(startDateOfTheTask.substring(0, 2)));
                console.log(`startday = ${startday}`);
                var startmonth = parseInt(startDateOfTheTask.substring(3, 5));
                console.log(`startmonth = ${startmonth}`);

                d = (numberOfDays + startday);
                //console.log(`numberOfDays is ${numberOfDays}`);
                m = (numberOfMonthes + startmonth);
                //console.log(`numberOfMonthes is ${numberOfMonthes}`);

                if (d > 30) {
                    d = d - 30;
                    m++;
                    E = `${d}-${m}-2020`;
                } else {
                    E = `${d}-${m}-2020`;
                }
            }
        }
    }
    return E;
}

var Percen01 = [100, 20, 40, 20, 10, 30];
var Percen02 = [100, 40, 25, 15, 15, 45];
var Percen03 = [100, 40, 60, 40];
var PhaseOne = [
    {
        "id":1,
        "text" : 'Total Project Duration',
        "start_date": "01-01-2020",
        "duration": "200",
        type: gantt.config.types.project,
        "progress": 1,
        "open": true
        //start: document.getElementById("ProjectStartDate").value,
        //end: document.getElementById("ProjectEndDate").value,
        //name: 'Gaurd Room Project',
        //id: "0",
        //progress: 100,
        //dependencies: '',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    }
];
var PhaseTwo = [
    {	
        "id": 11,
        "text": 'Architecture Design',
        "start_date": `${CalculateStartDate(Percen01, 11, 1)}`,
        "duration": `${CalculateDays(PhaseOne[0].start_date, PhaseOne[0].duration, 20)}`,
        type: gantt.config.types.project,
        "parent": "1",
        "progress": 1,
        "open": true
        //start: CalculateStartDate(Percen01, "0-0", "0"),
        //end: CalculateEndDate(Percen01, "0-0", "0", 20),
        //name: 'Architecture Design',
        //id: "0-0",
        //progress: 100,
        //dependencies: '0',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    },
    {
        "id": 12,
        "text": 'Construction Work',
        "start_date": `${CalculateStartDate(Percen02, 12, 1)}`,
        "duration": `${CalculateDays(PhaseOne[0].start_date, PhaseOne[0].duration, 40)}`,
        type: gantt.config.types.project,
        "parent": "1",
        "progress": 1,
        "open": true
        //start: CalculateStartDate(Percen02, "0-1", "0"),
        //end: CalculateEndDate(Percen02, "0-1", "0", 40),
        //name: 'Construction Work',
        //id: "0-1",
        //progress: 100,
        //dependencies: '0-0',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    },
    {
        "id": 13,
        "text": 'Decoration Work',
        "start_date": `${CalculateStartDate(Percen03, 13, 1)}`,
        "duration": `${CalculateDays(PhaseOne[0].start_date, PhaseOne[0].duration, 40)}`,
        type: gantt.config.types.project,
        "parent": "1",
        "progress": 1,
        "open": true
        //start: CalculateStartDate(Percen03, "0-2", "0"),
        //end: CalculateEndDate(Percen03, "0-2", "0", 40),
        //name: 'Decoration Work',
        //id: "0-2",
        //progress: 100,
        //dependencies: '0-1',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    },
];
var PhaseThree = [
    {
        "id": 111,
        "text": 'Draft_Architecture_Drawings',
        "start_date": `${CalculateStartDate(Percen01, 111, 11)}`,
        "duration": `${CalculateDays(PhaseTwo[0].start_date, PhaseTwo[0].duration, 40)}`,
        type: gantt.config.types.task,
        "parent": "11",
        "progress": 1,
        "open": true
        //start: CalculateStartDate(Percen01, "0-0-0", "0-0"),
        //end: CalculateEndDate(Percen01, "0-0-0", "0-0", 40),
        //name: 'Draft_Architecture_Drawings',
        //id: "0-0-0",
        //progress: 50,
        //dependencies: '0-0',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    },
    {
        "id": 112,
        "text": 'Prepare_Construction_Drawings',
        "start_date": `${CalculateStartDate(Percen01, 112, 11)}`,
        "duration": `${CalculateDays(PhaseTwo[0].start_date, PhaseTwo[0].duration, 20)}`,
        type: gantt.config.types.task,
        "parent": "11",
        "progress": 1,
        "open": true
        //start: CalculateStartDate(Percen01, "0-0-1", "0-0"),
        //end: CalculateEndDate(Percen01, "0-0-1", "0-0", 20),
        //name: 'Prepare_Construction_Drawings',
        //id: "0-0-1",
        //progress: 40,
        //dependencies: '0-0-0',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    },
    {
        "id": 113,
        "text": 'Agreement_Of_The_Drawings',
        "start_date": `${CalculateStartDate(Percen01, 113, 11)}`,
        "duration": `${CalculateDays(PhaseTwo[0].start_date, PhaseTwo[0].duration, 10)}`,
        type: gantt.config.types.task,
        "parent": "11",
        "progress": 1,
        "open": true
        //start: CalculateStartDate(Percen01, "0-0-2", "0-0"),
        //end: CalculateEndDate(Percen01, "0-0-2", "0-0", 10),
        //name: 'Agreement_Of_The_Drawings',
        //id: "0-0-2",
        //progress: 30,
        //dependencies: '0-0-1',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    },
    {
        "id": 114,
        "text": 'Sign_Agreement_With_Owner',
        "start_date": `${CalculateStartDate(Percen01, 114, 11)}`,
        "duration": `${CalculateDays(PhaseTwo[0].start_date, PhaseTwo[0].duration, 30)}`,
        type: gantt.config.types.task,
        "parent": "11",
        "progress": 1,
        "open": true
        //start: CalculateStartDate(Percen01, "0-0-3", "0-0"),
        //end: CalculateEndDate(Percen01, "0-0-3", "0-0", 30),
        //name: 'Sign_Agreement_With_Owner',
        //id: "0-0-3",
        //progress: 15,
        //dependencies: '0-0-2',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    },
    {
        "id": 121,
        "text": 'Excavation',
        "start_date": `${CalculateStartDate(Percen02, 121, 12)}`,
        "duration": `${CalculateDays(PhaseTwo[1].start_date, PhaseTwo[1].duration, 25)}`,
        type: gantt.config.types.task,
        "parent": "12",
        "progress": 1,
        "open": true
        //start: CalculateStartDate(Percen02, "0-1-0", "0-1"),
        //end: CalculateEndDate(Percen02, "0-1-0", "0-1", 25),
        //name: 'Excavation',
        //id: "0-1-0",
        //progress: 25,
        //dependencies: '0-0-3',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    },
    {
        "id": 122,
        "text": 'Pour Concrete',
        "start_date": `${CalculateStartDate(Percen02, 122, 12)}`,
        "duration": `${CalculateDays(PhaseTwo[1].start_date, PhaseTwo[1].duration, 15)}`,
        type: gantt.config.types.task,
        "parent": "12",
        "progress": 1,
        "open": true
        //start: CalculateStartDate(Percen02, "0-1-1", "0-1"),
        //end: CalculateEndDate(Percen02, "0-1-1", "0-1", 15),
        //name: 'Pour Concrete',
        //id: "0-1-1",
        //progress: 30,
        //dependencies: '0-1-0',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    },
    {
        "id": 123,
        "text": 'Level Concrete',
        "start_date": `${CalculateStartDate(Percen02, 123, 12)}`,
        "duration": `${CalculateDays(PhaseTwo[1].start_date, PhaseTwo[1].duration, 15)}`,
        type: gantt.config.types.task,
        "parent": "12",
        "progress": 1,
        "open": true
        //start: CalculateStartDate(Percen02, "0-1-2", "0-1"),
        //end: CalculateEndDate(Percen02, "0-1-2", "0-1", 15),
        //name: 'Level Concrete',
        //id: "0-1-2",
        //progress: 75,
        //dependencies: '0-1-1',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    },
    {
        "id": 124,
        "text": 'Column Work',
        "start_date": `${CalculateStartDate(Percen02, 124, 12)}`,
        "duration": `${CalculateDays(PhaseTwo[1].start_date, PhaseTwo[1].duration, 45)}`,
        type: gantt.config.types.task,
        "parent": "12",
        "progress": 1,
        "open": true
        //start: CalculateStartDate(Percen02, "0-1-3", "0-1"),
        //end: CalculateEndDate(Percen02, "0-1-3", "0-1", 45),
        //name: 'Column Work',
        //id: "0-1-3",
        //progress: 45,
        //dependencies: '0-1-2',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    },
    {
        "id": 131,
        "text": 'Painting And Tiling',
        "start_date": `${CalculateStartDate(Percen03, 131, 13)}`,
        "duration": `${CalculateDays(PhaseTwo[2].start_date, PhaseTwo[2].duration, 60)}`,
        type: gantt.config.types.task,
        "parent": "13",
        "progress": 1,
        "open": true
        //start: CalculateStartDate(Percen03, "0-2-0", "0-2"),
        //end: CalculateEndDate(Percen03, "0-2-0", "0-2", 60),
        //name: 'Painting And Tiling',
        //id: "0-2-0",
        //progress: 15,
        //dependencies: '0-1-3',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    },
    {
        "id": 132,
        "text": 'Interiors And Furniture',
        "start_date": `${CalculateStartDate(Percen03, 132, 13)}`,
        "duration": `${CalculateDays(PhaseTwo[2].start_date, PhaseTwo[2].duration, 40)}`,
        type: gantt.config.types.task,
        "parent": "13",
        "progress": 1,
        "open": true
        //start: CalculateStartDate(Percen03, "0-2-1", "0-2"),
        //end: CalculateEndDate(Percen03, "0-2-1", "0-2", 40),
        //name: 'Interiors And Furniture',
        //id: "0-2-1",
        //progress: 79,
        //dependencies: '0-2-0',
        //custom_class: 'bar-milestone',
        //DependantElements: ""
    },
];


console.log(PhaseThree);
console.log(PhaseTwo);

var tasks = [

]

for (var i = 0; i < 1; i++) {
    tasks.push(PhaseOne[i]);
}


for (var i = 0; i < 1; i++) {
    tasks.push(PhaseTwo[i]);
}
for (var i = 0; i < 4; i++) {
    tasks.push(PhaseThree[i]);
}


for (var i = 1; i < 2; i++) {
    tasks.push(PhaseTwo[i]);
}

for (var i = 4; i < 8; i++) {
    tasks.push(PhaseThree[i]);
}


for (var i = 2; i < 3; i++) {
    tasks.push(PhaseTwo[i]);
}
for (var i = 8; i < 10; i++) {
    tasks.push(PhaseThree[i]);
}









var demo_tasks = {
    "data": tasks
};

function generateData(count, dateFrom, dateTo){
	var tasks =  {
		data:[],
		links:[]
	};

	count = parseInt(count, 10) || 100;

	var date = new Date(dateFrom.getFullYear(),5,1);
	var project_id = 1;
	tasks.data.push({
		id:  project_id,
		text: "Project1",
		start_date: date,
		type: gantt.config.types.project,
		open:true
	});
	for (var i = 1; i < count; i++) {
		date = gantt.date.add(date, 1, "day");
		var task = {
			id: i + 1,
			start_date: date,
			text: "Task " + (i + 1),
			duration: 8,
			parent: project_id
		};

		if(gantt.date.add(date, 8, "day").valueOf() > dateTo.valueOf()){
			date = new Date(dateFrom);
			project_id = i + 1;
			delete task.parent;
			task.open = true;
		}
		tasks.data.push(task);

	}
	return tasks;
}