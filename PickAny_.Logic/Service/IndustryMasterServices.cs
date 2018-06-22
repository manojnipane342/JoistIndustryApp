using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PickAny_.Logic.Interface;
using PickAny_.Model;

namespace PickAny_.Logic.Service
{
    public class IndustryMasterServices : IIndustryMaster
    {
        private PickAnyLiveEntities dbcontext = new PickAnyLiveEntities();
        public Result<Model.IndustryMaster> Save(Model.IndustryMaster industrymaster)
        {
            Result<PickAny_.Model.IndustryMaster> _Result = new Result<PickAny_.Model.IndustryMaster>();

            try
            {
                _Result.IsSuccess = false;

                if (industrymaster.Id == 0)
                {
                    var _industryExists = dbcontext.Industries.Where(c => c.Name == industrymaster.Name).FirstOrDefault();
                    if (_industryExists == null)
                    {
                        Industry IndustryMaster = new Logic.Industry();
                        IndustryMaster.Name = industrymaster.Name;
                        IndustryMaster.IsActive = industrymaster.IsActive;

                        dbcontext.Industries.Add(IndustryMaster);
                        dbcontext.SaveChanges();

                        _Result.IsSuccess = true;
                    }
                    else
                    {
                        _Result.IsSuccess = false;
                    }

                }
                else
                {
                    var _industryExists = dbcontext.Industries.Where(c => c.Id == industrymaster.Id).FirstOrDefault();
                    if (_industryExists != null)
                    {

                        _industryExists.Name = industrymaster.Name;
                        dbcontext.SaveChanges();
                        _Result.IsSuccess = true;
                    }
                    else
                    {
                        _Result.IsSuccess = false;
                    }
                }
            }
            catch (Exception ex)
            {
                _Result.IsSuccess = false;
                _Result.Message = ex.Message;
                _Result.Exception = ex.InnerException;
            }

            return _Result;
        }

        public Result<Boolean> Delete(int id)
        {
            Result<Boolean> _Result = new Result<Boolean>();

            try
            {
                _Result.IsSuccess = false;

                var _industryExists = dbcontext.Industries.Where(c => c.Id == id).FirstOrDefault();
                if (_industryExists != null)
                {
                    dbcontext.Industries.Remove(_industryExists);
                    dbcontext.SaveChanges();

                    _Result.IsSuccess = true;

                }
                else
                {
                    _Result.IsSuccess = false;

                }
            }
            catch (Exception ex)
            {
                _Result.IsSuccess = false;
                _Result.Message = ex.Message;
                _Result.Exception = ex.InnerException;
            }

            return _Result;
        }

        public Result<List<Model.IndustryMaster>> GetIndustryList()
        {
            Result<List<Model.IndustryMaster>> _Result = new Result<List<Model.IndustryMaster>>();

            try
            {
                _Result.IsSuccess = false;

                var _industryList = dbcontext.Industries.Select(c => new Model.IndustryMaster
                {

                    Id = c.Id,
                    Name = c.Name,
                    IsActive = c.IsActive ?? false

                }).ToList();

                if (_industryList.Count == 0 || _industryList != null)
                {
                    _Result.Data = _industryList;
                }
                else
                {
                    _Result.IsSuccess = false;

                }
            }
            catch (Exception ex)
            {
                _Result.IsSuccess = false;
                _Result.Message = ex.Message;
                _Result.Exception = ex.InnerException;
            }

            return _Result;
        }

        public Result<Model.IndustryMaster> GetIndustryById(int industryId)
        {
            Result<Model.IndustryMaster> _Result = new Result<Model.IndustryMaster>();

            try
            {
                _Result.IsSuccess = false;

                var _industryList = dbcontext.Industries.Where(x => x.Id == industryId).Select(c => new Model.IndustryMaster
                {

                    Id = c.Id,
                    Name = c.Name,
                    IsActive=c.IsActive ?? false

                }).FirstOrDefault();

                if (_industryList != null)
                {
                    _Result.Data = _industryList;
                }
                else
                {
                    _Result.IsSuccess = false;

                }
            }
            catch (Exception ex)
            {
                _Result.IsSuccess = false;
                _Result.Message = ex.Message;
                _Result.Exception = ex.InnerException;
            }

            return _Result;
        }
    }
}
