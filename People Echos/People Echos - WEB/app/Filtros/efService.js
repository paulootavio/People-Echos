


//Filtros

(function (angular) {
    app.factory('efService', ["$http",
        function ($http) {
            var dataLoad = {};

            return {
                LoadTipoFichas: LoadTipoFichas,
                Loadquestoes: Loadquestoes,
                LoadResposta: LoadResposta,
                LoadFichaCompleta: LoadFichaCompleta,
                listQuestoesCheck: listQuestoesChecks,
                QuestoesChecks: QuestoesChecks
            };


            function LoadTipoFichas () {
                return $http.get('/Filtros/LoadTipoFichas');
            };

            function Loadquestoes(idAvaliacao) {
                return $http.get('/Filtros/ListQuestoes?idAvaliacao=' + idAvaliacao);
            }

            function listQuestoesChecks(idAvaliacao) {
                return $http.get('/Filtros/listQuestoesChecks?idAvaliacao=' + idAvaliacao);
            }
            function QuestoesChecks(idAvaliacao) {
                return $http.get('/Filtros/QuestoesChecks?idAvaliacao=' + idAvaliacao);
            }
            
            function LoadResposta(idQuestao, resposta) {
                return $http.get('/Filtros/listResposta?idQuestao=' + idQuestao + '&&resposta=' + resposta);
            }
            function LoadFichaCompleta(idAvaliacao, idUser) {
                return $http.get('/Filtros/FichaCompleta?idAvaliacao=' + idAvaliacao + '&&idUser=' + idUser);
            }
        }]);
})(window.angular);

