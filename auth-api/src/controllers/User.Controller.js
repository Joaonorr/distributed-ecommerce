import UserService from "../service/User.service.js";

/**
 * @class UserController
 * @description Classe responsável por implementar os métodos do controller da entidade User
 * @exports UserController
 * @access public
 * @version 1.0.0
 */
class UserController {

    async findByEmail(req, res) {

        let result = await UserService.findByEmail(req, res);

        return res.status(result.status).json(result.data);
    }

    async findById(req, res) {

        let result = await UserService.findById(req, res);

        return res.status(result.status).json(result.data);
    }

    async getAuthToken(req, res) {
            
        let result = await UserService.getAuthToken(req, res);

        return res.status(result.status).json(result.data);
    }
}

export default new UserController();