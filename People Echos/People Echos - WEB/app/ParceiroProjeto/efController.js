(function (angular) {

    app.controller('efcontroller', ['efService', '$scope', function (efService, $scope) {
        $scope.loadForm = false;
        $scope.heartLoad = true;

        var data = efService.query();

        $scope.Questao53 = {};
        $scope.Questao54 = {};
        $scope.Questao55 = {};
        $scope.Questao56 = {};
        $scope.Questao57 = {};
        $scope.Questao58 = {};
        $scope.Questao59 = {};
        $scope.Questao60 = {};
        $scope.Questao62 = {};
   
        data.then(function (emp) {
            $scope.questoes = emp.data.model;
        
            $scope.questaoCursosEDT = emp.data.questaoCursosEDT;
            $scope.questaoAplicarEDT = emp.data.questaoAplicarEDT;
            $scope.questaoAreas = emp.data.questaoAreas;
          
            $.each($scope.questoes, function (index, questao) {                
                if (questao.idQuestao == 53) {
                    $scope.Questao53 = questao;
                }
                if (questao.idQuestao == 54) {
                    $scope.Questao54 = questao;
                }
                if (questao.idQuestao == 55) {
                    $scope.Questao55 = questao;
                }
                if (questao.idQuestao == 56) {
                    $scope.Questao56 = questao;
                }
                if (questao.idQuestao == 57) {
                    $scope.Questao57 = questao;
                }
                if (questao.idQuestao == 58) {
                    $scope.Questao59 = questao;
                }
                if (questao.idQuestao == 60) {
                    $scope.Questao60 = questao;
                }
                if (questao.idQuestao == 62) {
                    $scope.Questao62 = questao;
                }
            
            });
            $scope.loadForm = true;
            $scope.heartLoad = false;
        });
        $scope.submit = function () {
            debugger;
       
            var data = [];
     
            data.push($scope.Questao53);
            data.push($scope.Questao54);
            data.push($scope.Questao55);
            data.push($scope.Questao56);
            data.push($scope.Questao57);
            data.push($scope.Questao58);
            data.push($scope.Questao59);
            data.push($scope.Questao60);
            data.push($scope.Questao62);
                
            efService.Submit(data, $scope.questaoCursosEDT)
                .success(function () {
                window.location = '/Home/Index';
                }
            );
        };     
    }]);

})(window.angular);

