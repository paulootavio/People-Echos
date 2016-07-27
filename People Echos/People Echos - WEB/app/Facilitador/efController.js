(function (angular) {

    app.controller('efcontroller', ['efService', '$scope', function (efService, $scope) {
        $scope.loadForm = false;
        $scope.heartLoad = true;

        var data = efService.query();

        $scope.Questao26 = {};
        $scope.Questao27 = {};
        $scope.Questao28 = {};
        $scope.Questao29 = {};
        $scope.Questao30 = {};
        $scope.Questao34 = {};
        $scope.Questao35 = {};
        $scope.Questao36 = {};
        $scope.Questao37 = {};
        $scope.Questao38 = {};
 
        data.then(function (emp) {
            $scope.questoes = emp.data.model;
        
            $scope.questaoCursosEDT = emp.data.questaoCursosEDT;
            $scope.questaoAplicarEDT = emp.data.questaoAplicarEDT;
            $scope.questaoAreas = emp.data.questaoAreas;
          
            $.each($scope.questoes, function (index, questao) {                
                if (questao.idQuestao == 26) {
                    $scope.Questao26 = questao;
                }
                if (questao.idQuestao == 27) {
                    $scope.Questao27 = questao;
                }
                if (questao.idQuestao == 28) {
                    $scope.Questao29 = questao;
                }
                if (questao.idQuestao == 29) {
                    $scope.Questao29 = questao;
                }
                if (questao.idQuestao == 30) {
                    $scope.Questao30 = questao;
                }
                if (questao.idQuestao == 34) {
                    $scope.Questao34 = questao;
                }
                if (questao.idQuestao == 35) {
                    $scope.Questao35 = questao;
                }
                if (questao.idQuestao == 36) {
                    $scope.Questao36 = questao;
                }
                if (questao.idQuestao == 37) {
                    $scope.Questao37 = questao
                }
                if (questao.idQuestao == 38) {
                    $scope.Questao38 = questao;
                }                       
            });
            $scope.loadForm = true;
            $scope.heartLoad = false;
        });
        $scope.submit = function () {

            // check to make sure the form is completely valid
            if ($scope.$valid) {
                alert('our form is amazing');
            }

        };
        $scope.submit = function () {
            debugger;
       
            var data = [];
                
            data.push($scope.Questao26);
            data.push($scope.Questao27);
            data.push($scope.Questao28);
            data.push($scope.Questao29);
            data.push($scope.Questao30);
            data.push($scope.Questao34);
            data.push($scope.Questao35);
            data.push($scope.Questao36);
            data.push($scope.Questao37);
            data.push($scope.Questao38);
             
            efService.Submit(data, $scope.questaoCursosEDT, $scope.questaoAplicarEDT, $scope.questaoAreas)
                .success(function () {
                window.location = '/Home/Index';
                }
            );
        };     
    }]);

})(window.angular);

