﻿adminModule.controller("burQueueCtrl", ["$scope", "$filter", "Submissions",

    function ($scope, $filter, Submissions) {
        
        $scope.dataSource = new kendo.data.DataSource({
                transport: {
                    read: function (e) {
                        Submissions.query(function (data) {
                            $scope.submissions = data;
                            e.success(
                                data.map(
                                    function (subm) {
                                        return {
                                            academicTerm: subm.session.academicTerm,
                                            sessionCode: subm.session.sessionCode,
                                            sessionName: subm.session.sessionName,
                                            userEmail: subm.session.userEmail,
                                            userPhone: subm.session.userPhone,
                                            uscCampusLocation: subm.session.uscCampusLocation,
                                            lastDayForAddDrop: $filter('date')(subm.session.lastDayForAddDrop, "mediumDate"),
                                            lastDayForWithdrawal: $filter('date')(subm.session.lastDayForWithdrawal, "mediumDate"),
                                            lastDayForEnrollmentOptionChange: $filter('date')(subm.session.lastDayForEnrollmentOptionChange, "mediumDate"),
                                            firstDayOfClass: $filter('date')(subm.session.firstDayOfClass, "mediumDate"),
                                            lastDayOfClass: $filter('date')(subm.session.lastDayOfClass, "mediumDate"),
                                            firstDayOfFinals: $filter('date')(subm.session.firstDayOfFinals, "mediumDate"),
                                            lastDayOfFinals: $filter('date')(subm.session.lastDayOfFinals, "mediumDate"),
                                            firstDayForFinalGrading: $filter('date')(subm.session.firstDayForFinalGrading, "mediumDate"),
                                            lastDayForFinalGrading: $filter('date')(subm.session.lastDayForFinalGrading, "mediumDate"),
                                            rateType: getRateTypeDescription(subm.session.rateType),
                                            ratePerUnitAmount: subm.session.ratePerUnitAmount,
                                            rateFlatAmount: subm.session.rateFlatAmount,
                                            flatRateUnitsMin: subm.session.flatRateUnitsMin,
                                            flatRateUnitsMax: subm.session.flatRateUnitsMax,
                                            owningSchool: subm.session.owningSchool,
                                            userContact: subm.session.userContact,
                                            requestDate: $filter('date')(subm.session.requestDate, "mediumDate"),
                                            sections: subm.session.sections,
                                            sessionBreaks: subm.session.sessionBreaks,
                                            comments: subm.session.comments,
                                            faoAction: subm.faoAction,
                                            faoActionDate: $filter('date')(subm.faoActionDate, "mediumDate"),
                                            faoActionReason: subm.faoActionReason,
                                            rnrAction: subm.rnrAction,
                                            rnrActionDate: $filter('date')(subm.rnrActionDate, "mediumDate"),
                                            rnrActionReason: subm.rnrActionReason,
                                            submissionId: subm.submissionId,
                                            requestId: subm.requestId
                                        };
                                    }));
                        }, function (error) {
                            alert("Cannot load submissions. " + error.data.message);
                            //                                e.error(new Error("Cannot load users. " + error.data.message));
                        });
                    }   // read: function()
                },      // transport {
                schema: {
                    model: {
                        fields: {
                            sessionCode: { type: "string" },
                            sessionName: { type: "string" },
                            owningSchool: { type: "string" },
                            userContact: { type: "string" },
                            requestDate: { type: "string" }
                        }
                    }
                },
                pageSize: 5,
                serverPaging: true,
                serverSorting: true
        });


        $scope.mainGridOptions = {

            dataSource: $scope.dataSource,
            sortable: true,
            pageable: true,
            columns: [
                { field: "academicTerm", title: "Term", width: "10%" },
                { field: "sessionCode", title: "Session", width: "10%" },
                { field: "sessionName", title: "Session Name", width: "20%" },
                { field: "owningSchool", title: "School", width: "20%" },
                { field: "owningDepartment", title: "Department", width: "15%" },
                { field: "requestDate", title: "Date", width: "10%" },
            ],
            editable: "popup"
        };


        function getRateTypeDescription(rateTypeCode) {

                    // Rate type lookup table
            var rateTypes = [
                { rateCode: "STD",  rateName: "Standard (session 001)" },
                { rateCode: "GBUS", rateName: "Graduate Business" },
                { rateCode: "GCINA",rateName: "Graduate Cinematic Arts" },
                { rateCode: "GENGR",rateName: "Graduate Engineering" },
                { rateCode: "MRED", rateName: "Master of Real Estate Development" },
                { rateCode: "PHAR", rateName: "Pharmacy" },
                { rateCode: "DENT", rateName: "Dentistry" },
                { rateCode: "DH",   rateName: "Dental Hygiene" },
                { rateCode: "ADVDE",rateName: "Advanced Dentistry" },
                { rateCode: "LAW",  rateName: "Law" },
                { rateCode: "MED",  rateName: "Medicine" },
                { rateCode: "OTH",  rateName: "Others" }
            ];

            var rateDesc = "";

            for (var i = 0; i < rateTypes.length; ++i) {
                if (rateTypes[i].rateCode == rateTypeCode) {
                    rateDesc = rateTypes[i].rateName;
                    break;
                }
            }
        return rateDesc;
    }   // getRateTypeDescription()

    $scope.sectionGridOptions = function (dataItem) {

        return {
            dataSource: {
                data: dataItem.sections,
                pageSize: 5
            },
            scrollable: false,
            sortable: true,
            pageable: true,
            columns: [
                { field: "sectionNumber", title: "Section", width: "50px" },
                { field: "title", title: "Section Title", width: "200px" },
                { field: "unitValue", title: "Units", width: "50px" },
                { field: "instructorName", title: " Name", width: "150px" } //,
            ]
        };
    };

    $scope.scheduleGridOptions = function (dataItem) {
        return {
            dataSource: {
                data: dataItem.schedules,
                pageSize: 5,
            },
            scrollable: false,
            sortable: true,
            pageable: true,
            columns: [
                { field: "classDayOfWeek", title: "Class Day", width: "100px" },
                { field: "classStartTime", title: "Start Time", width: "150px" },
                { field: "classEndTime", title: "End Time", width: "150px" }
            ]
        };
    };

    $scope.sessionBrkGridOptions = function (dataItem) {
        return {
                dataSource: {
                    data: dataItem.sessionBreaks,
                    pageSize: 5,
                    schema: {
                        model: {
                            fields: {
                                startDate: { type: "date" },
                                endDate: { type: "date" }
                            }
                        }
                    }
                },
                scrollable: false,
                sortable: true,
                pageable: true,
                columns: [
                    { field: "startDate", title: "Start Date", format: "{0:MMM dd, yyyy}" },
                    { field: "endDate", title: "End Date", format: "{0:MMM dd, yyyy}" }
                ]
            };
    };  // $scope.sessionBrkGridOptions

}]);