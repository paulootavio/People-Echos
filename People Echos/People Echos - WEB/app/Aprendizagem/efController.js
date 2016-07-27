(function (angular) {

    app.controller('efcontroller', ['efService', '$scope', function (efService, $scope) {
        $scope.loadForm = false;
        $scope.heartLoad = true;

        var data = efService.query();

        $scope.Questao39 = {};
        $scope.Questao40 = {};
        $scope.Questao41 = {};
        $scope.Questao42 = {};
        $scope.Questao43 = {};
        $scope.Questao44 = {};
        $scope.Questao45 = {};
        $scope.Questao46 = {};
        $scope.Questao47 = {};
        $scope.Questao49 = {};
        $scope.Questao50 = {};
        $scope.Questao51 = {};
        $scope.Questao52 = {};
  
        data.then(function (emp) {
            $scope.questoes = emp.data.model;
            debugger;
            $scope.questaoCursosEDT = emp.data.questaoCursosEDT;
            $.each($scope.questoes, function (index, questao) {                
                if (questao.idQuestao == 39) {
                    $scope.Questao39 = questao
                }
                if (questao.idQuestao == 40) {
                    $scope.Questao40 = questao
                }
                if (questao.idQuestao == 41) {
                    $scope.Questao41 = questao
                }
                if (questao.idQuestao == 42) {
                    $scope.Questao42 = questao
                }
                if (questao.idQuestao == 43) {
                    $scope.Questao43 = questao
                }
                if (questao.idQuestao == 44) {
                    $scope.Questao44 = questao
                }
                if (questao.idQuestao == 45) {
                    $scope.Questao45 = questao
                }
                if (questao.idQuestao == 47) {
                    $scope.Questao46 = questao
                }
                if (questao.idQuestao == 49) {
                    $scope.Questao47 = questao
                }
                if (questao.idQuestao == 50) {
                    $scope.Questao50 = questao
                }
                if (questao.idQuestao == 51) {
                    $scope.Questao51 = questao
                }
                if (questao.idQuestao == 52) {
                    $scope.Questao52 = questao
                }              
            });
            $scope.loadForm = true;
            $scope.heartLoad = false;
        });
        $scope.submit = function () {
            debugger;
       
            var data = [];
     
            data.push($scope.Questao39);
            data.push($scope.Questao40);
            data.push($scope.Questao41);
            data.push($scope.Questao42);
            data.push($scope.Questao43);
            data.push($scope.Questao44);
            data.push($scope.Questao45);
            data.push($scope.Questao46);
            data.push($scope.Questao47);
            data.push($scope.Questao49);
            data.push($scope.Questao50);
            data.push($scope.Questao51);
            data.push($scope.Questao52);
          
          
            efService.Submit(data, $scope.questaoCursosEDT)
                .success(function () {
                window.location = '/Home/Index';
                }
            );
        };     
    }]);

})(window.angular);

